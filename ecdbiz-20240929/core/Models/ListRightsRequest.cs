// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EcdBiz20240929.Models
{
    public class ListRightsRequest : TeaModel {
        /// <summary>
        /// <para>Optional AI rights filter. Set to true to query only AI rights, or false to query only regular rights, including historical unmarked rights. If you do not specify this parameter, all rights are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AiDesktop")]
        [Validation(Required=false)]
        public bool? AiDesktop { get; set; }

        /// <summary>
        /// <para>The scenario code for the commercial edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GENERAL_OFFICE</para>
        /// </summary>
        [NameInMap("BusinessSceneCode")]
        [Validation(Required=false)]
        public string BusinessSceneCode { get; set; }

        /// <summary>
        /// <para>The maximum number of results per page. Specify a positive integer from 1 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Do not specify this parameter for the first query. For subsequent queries, pass the NextToken value returned from the previous page exactly as it was returned. The example is for illustration purposes only. Do not construct the token manually.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b5f4e3d2c1a09876b5f4e3d2c1a09876</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results, such as gmtCreate, rightsId, or rightsExpireTime. If you do not specify this parameter, the default sorting order of the server is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmtCreate</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values: asc and desc (lowercase). Use this parameter together with OrderField.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>Specifies whether the rights apply to regions outside the Chinese mainland, including Hong Kong (China), Macao (China), and Taiwan (China). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The Chinese mainland.</description></item>
        /// <item><description>1: Regions outside the Chinese mainland, including Hong Kong (China), Macao (China), and Taiwan (China).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Overseas")]
        [Validation(Required=false)]
        public int? Overseas { get; set; }

        /// <summary>
        /// <para>The rights activation status. Use the returned value to determine whether the activation is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTED</para>
        /// </summary>
        [NameInMap("RightsActiveStatus")]
        [Validation(Required=false)]
        public string RightsActiveStatus { get; set; }

        /// <summary>
        /// <para>The end user to whom the rights are assigned. For convenience accounts, use EndUserId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-example</para>
        /// </summary>
        [NameInMap("RightsAssignedUser")]
        [Validation(Required=false)]
        public string RightsAssignedUser { get; set; }

        /// <summary>
        /// <para>The list of rights IDs to query or activate. Specify the RightsId values returned by ListRights.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;New_beds-example_0001&quot;]</para>
        /// </summary>
        [NameInMap("RightsIds")]
        [Validation(Required=false)]
        public List<string> RightsIds { get; set; }

        /// <summary>
        /// <para>The rights period code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUSINESS_WEEK_1</para>
        /// </summary>
        [NameInMap("RightsPeriod")]
        [Validation(Required=false)]
        public string RightsPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the resource associated with the rights. This value is returned after the resource is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-example</para>
        /// </summary>
        [NameInMap("RightsResourceId")]
        [Validation(Required=false)]
        public string RightsResourceId { get; set; }

        /// <summary>
        /// <para>The rights resource type. Use Desktop for regular cloud computers. For other commodities, specify the actual rights type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop</para>
        /// </summary>
        [NameInMap("RightsResourceType")]
        [Validation(Required=false)]
        public string RightsResourceType { get; set; }

        /// <summary>
        /// <para>The list of rights resource types to filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Desktop&quot;]</para>
        /// </summary>
        [NameInMap("RightsResourceTypes")]
        [Validation(Required=false)]
        public List<string> RightsResourceTypes { get; set; }

        /// <summary>
        /// <para>The rights specification code. Refer to the rights query results for the actual value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.business_edition_office.4c8g</para>
        /// </summary>
        [NameInMap("RightsSpec")]
        [Validation(Required=false)]
        public string RightsSpec { get; set; }

    }

}
