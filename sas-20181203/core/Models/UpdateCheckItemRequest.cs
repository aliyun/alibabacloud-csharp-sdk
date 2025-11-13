// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateCheckItemRequest : TeaModel {
        /// <summary>
        /// <para>Help information for the check item.</para>
        /// </summary>
        [NameInMap("AssistInfo")]
        [Validation(Required=false)]
        public UpdateCheckItemRequestAssistInfo AssistInfo { get; set; }
        public class UpdateCheckItemRequestAssistInfo : TeaModel {
            /// <summary>
            /// <para>Type of the help information for the check item risk. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b>: Text</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Content of the help information for the check item risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom assistInfo.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>ID of the custom check item to be updated.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCheckItems~~">ListCheckItems</a> API to get this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000000001</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>Definition rule for the custom check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AssociatedData&quot;:{&quot;ToDataList&quot;:[{&quot;DataName&quot;:&quot;ACS_ECS_Instance&quot;,&quot;PropertyPath&quot;:&quot;InstanceId&quot;,&quot;FromPropertyPath&quot;:&quot;InstanceId&quot;}]},&quot;MatchProperty&quot;:{&quot;Operator&quot;:&quot;AND&quot;,&quot;MatchProperties&quot;:[{&quot;DataName&quot;:&quot;ACS_ECS_Disk&quot;,&quot;PropertyPath&quot;:&quot;InstanceId&quot;,&quot;MatchOperator&quot;:&quot;EQ&quot;,&quot;MatchPropertyValue&quot;:&quot;testId&quot;},{&quot;DataName&quot;:&quot;ACS_ECS_Instance&quot;,&quot;PropertyPath&quot;:&quot;InstanceId&quot;,&quot;MatchOperator&quot;:&quot;EQ&quot;,&quot;MatchPropertyValue&quot;:&quot;testInstanceId&quot;}]}}</para>
        /// </summary>
        [NameInMap("CheckRule")]
        [Validation(Required=false)]
        public string CheckRule { get; set; }

        /// <summary>
        /// <para>Name of the custom check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testCheckItemName</para>
        /// </summary>
        [NameInMap("CheckShowName")]
        [Validation(Required=false)]
        public string CheckShowName { get; set; }

        /// <summary>
        /// <para>Description of the check item.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public UpdateCheckItemRequestDescription Description { get; set; }
        public class UpdateCheckItemRequestDescription : TeaModel {
            /// <summary>
            /// <para>Type of the check item description. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b>: Text</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Description of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom description.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Sub-asset type of the cloud product.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCloudAssetSchemas~~">ListCloudAssetSchemas</a> API to get this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DISK</para>
        /// </summary>
        [NameInMap("InstanceSubType")]
        [Validation(Required=false)]
        public string InstanceSubType { get; set; }

        /// <summary>
        /// <para>Asset type of the cloud product.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCloudAssetSchemas~~">ListCloudAssetSchemas</a> API to get this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Remark information</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Risk level of the check item. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>HIGH</b>: High risk</description></item>
        /// <item><description><b>MEDIUM</b>: Medium risk</description></item>
        /// <item><description><b>LOW</b>: Low risk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>Array of section IDs associated with the check item.</para>
        /// </summary>
        [NameInMap("SectionIds")]
        [Validation(Required=false)]
        public List<long?> SectionIds { get; set; }

        /// <summary>
        /// <para>Solution information for the check item.</para>
        /// </summary>
        [NameInMap("Solution")]
        [Validation(Required=false)]
        public UpdateCheckItemRequestSolution Solution { get; set; }
        public class UpdateCheckItemRequestSolution : TeaModel {
            /// <summary>
            /// <para>Type of the solution information for the check item. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b>: Text</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Content of the solution for the check item risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom solution.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Status of the check item. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>EDIT</b>: In editing</description></item>
        /// <item><description><b>RELEASE</b>: Released</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Changing from <b>Released</b> to <b>In editing</b> will clear all historical records</description></item>
        /// <item><description>Only the <b>Released</b> status allows the use of the check item for inspection.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RELEASE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Cloud asset vendor.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCloudAssetSchemas~~">ListCloudAssetSchemas</a> API to get the available vendors.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
