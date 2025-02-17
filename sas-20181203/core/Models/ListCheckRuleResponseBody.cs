// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Check rules.</para>
        /// </summary>
        [NameInMap("CheckRules")]
        [Validation(Required=false)]
        public List<ListCheckRuleResponseBodyCheckRules> CheckRules { get; set; }
        public class ListCheckRuleResponseBodyCheckRules : TeaModel {
            /// <summary>
            /// <para>The UID of the current user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>176316827610****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The subtype of the cloud product.</para>
            /// <remarks>
            /// <para>For specific meanings, refer to the <a href="~~GetCloudAssetCriteria~~">GetCloudAssetCriteria</a> AssetSubType.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>The type of cloud asset.</para>
            /// <remarks>
            /// <para>For specific meanings, refer to the <a href="~~GetCloudAssetCriteria~~">GetCloudAssetCriteria</a> AssetType.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>77</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The display name of the check item section.</para>
            /// </summary>
            [NameInMap("CheckPolicies")]
            [Validation(Required=false)]
            public List<ListCheckRuleResponseBodyCheckRulesCheckPolicies> CheckPolicies { get; set; }
            public class ListCheckRuleResponseBodyCheckRulesCheckPolicies : TeaModel {
                /// <summary>
                /// <para>Display name of the item\&quot;s chapter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Access Control</para>
                /// </summary>
                [NameInMap("sectionShowName")]
                [Validation(Required=false)]
                public string SectionShowName { get; set; }

            }

            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Check for IPS Whitelist on CEN (Enterprise Edition) Tab</para>
            /// </summary>
            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

            /// <summary>
            /// <para>The sub-asset type of the cloud product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("InstanceSubType")]
            [Validation(Required=false)]
            public string InstanceSubType { get; set; }

            /// <summary>
            /// <para>The asset type of the cloud product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Remark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remark</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8000**</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The type of rule. Default is <b>WHITE</b>. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>WHITE</b>: Add to whitelist</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WHITE</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The scope where the rule applies. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>INSTNACE</b>: Instance</description></item>
            /// <item><description><b>ITEM</b>: Check item</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            /// <summary>
            /// <para>The server vendor. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
            /// <item><description><b>1</b>: Non-cloud asset</description></item>
            /// <item><description><b>2</b>: IDC asset</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: Other cloud assets</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

            /// <summary>
            /// <para>The name of the server provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

        }

        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckRuleResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckRuleResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of data entries displayed on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number in a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of data entries displayed per page in a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of data entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request, which is a unique identifier generated by Alibaba Cloud for the request. It can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52870893-48A7-5A9E-9E05-6253E5B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
