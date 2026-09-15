// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateCheckItemRequest : TeaModel {
        /// <summary>
        /// <para>The help information of the check item.</para>
        /// </summary>
        [NameInMap("AssistInfo")]
        [Validation(Required=false)]
        public CreateCheckItemRequestAssistInfo AssistInfo { get; set; }
        public class CreateCheckItemRequestAssistInfo : TeaModel {
            /// <summary>
            /// <para>The type of the help information for the check item risk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b>: text</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The content of the help information for the check item risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom assistInfo.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The rule definition of the custom check item.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AssociatedData&quot;:{&quot;ToDataList&quot;:[{&quot;DataName&quot;:&quot;ACS_ECS_Instance&quot;,&quot;PropertyPath&quot;:&quot;InstanceId&quot;,&quot;FromPropertyPath&quot;:&quot;InstanceId&quot;}]},&quot;MatchProperty&quot;:{&quot;Operator&quot;:&quot;AND&quot;,&quot;MatchProperties&quot;:[{&quot;DataName&quot;:&quot;ACS_ECS_Disk&quot;,&quot;PropertyPath&quot;:&quot;InstanceId&quot;,&quot;MatchOperator&quot;:&quot;EQ&quot;,&quot;MatchPropertyValue&quot;:&quot;testId&quot;},{&quot;DataName&quot;:&quot;ACS_ECS_Instance&quot;,&quot;PropertyPath&quot;:&quot;InstanceId&quot;,&quot;MatchOperator&quot;:&quot;EQ&quot;,&quot;MatchPropertyValue&quot;:&quot;testInstanceId&quot;}]}}</para>
        /// </summary>
        [NameInMap("CheckRule")]
        [Validation(Required=false)]
        public string CheckRule { get; set; }

        /// <summary>
        /// <para>The name of the custom check item.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testCheckItemName</para>
        /// </summary>
        [NameInMap("CheckShowName")]
        [Validation(Required=false)]
        public string CheckShowName { get; set; }

        /// <summary>
        /// <para>The description of the check item.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public CreateCheckItemRequestDescription Description { get; set; }
        public class CreateCheckItemRequestDescription : TeaModel {
            /// <summary>
            /// <para>The type of the check item description. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b>: text</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The content of the description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom description.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The asset subtype of the cloud service.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCloudAssetSchemas~~">ListCloudAssetSchemas</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DISK</para>
        /// </summary>
        [NameInMap("InstanceSubType")]
        [Validation(Required=false)]
        public string InstanceSubType { get; set; }

        /// <summary>
        /// <para>The asset type of the cloud service.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCloudAssetSchemas~~">ListCloudAssetSchemas</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The risk level of the check item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HIGH</b>: High risk.</description></item>
        /// <item><description><b>MEDIUM</b>: Medium risk.</description></item>
        /// <item><description><b>LOW</b>: Low risk.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LOW</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The IDs of the sections associated with the check item.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SectionIds")]
        [Validation(Required=false)]
        public List<long?> SectionIds { get; set; }

        /// <summary>
        /// <para>The solution information of the check item.</para>
        /// </summary>
        [NameInMap("Solution")]
        [Validation(Required=false)]
        public CreateCheckItemRequestSolution Solution { get; set; }
        public class CreateCheckItemRequestSolution : TeaModel {
            /// <summary>
            /// <para>The type of the check item solution information. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b>: text</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The content of the solution for the check item risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The status of the check item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EDIT</b>: Being edited.</description></item>
        /// <item><description><b>RELEASE</b>: Published.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Changing the status from <b>Published</b> to <b>Being edited</b> will purge all historical records.</description></item>
        /// <item><description>Only check items in the <b>Published</b> status can be used for checks.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDIT</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The cloud asset vendor.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCloudAssetSchemas~~">ListCloudAssetSchemas</a> operation to obtain the available vendors.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
