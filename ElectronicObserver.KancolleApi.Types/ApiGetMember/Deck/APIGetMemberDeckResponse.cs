﻿namespace ElectronicObserver.KancolleApi.Types.ApiGetMember.Deck;

public class ApiGetMemberDeckResponse
{
	[JsonPropertyName("api_flagship")]
	[JsonIgnore(Condition = JsonIgnoreCondition.Never)]
	[Required(AllowEmptyStrings = true)]
	public string ApiFlagship { get; set; } = default!;

	[JsonPropertyName("api_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.Never)]
	public int ApiId { get; set; } = default!;

	[JsonPropertyName("api_member_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.Never)]
	public int ApiMemberId { get; set; } = default!;

	[JsonPropertyName("api_mission")]
	[JsonIgnore(Condition = JsonIgnoreCondition.Never)]
	[Required]
	public List<long> ApiMission { get; set; } = new();

	[JsonPropertyName("api_name")]
	[JsonIgnore(Condition = JsonIgnoreCondition.Never)]
	[Required(AllowEmptyStrings = true)]
	public string ApiName { get; set; } = default!;

	[JsonPropertyName("api_name_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.Never)]
	[Required(AllowEmptyStrings = true)]
	public string ApiNameId { get; set; } = default!;

	[JsonPropertyName("api_ship")]
	[JsonIgnore(Condition = JsonIgnoreCondition.Never)]
	[Required]
	public List<int> ApiShip { get; set; } = new();
}
