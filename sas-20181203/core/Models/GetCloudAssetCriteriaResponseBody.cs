// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>An array consisting of the information about the filter conditions that are used to search for cloud assets.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<GetCloudAssetCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class GetCloudAssetCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The structured attribute values of the assets that match the keyword. The value of this parameter is in the JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>vendor</b>: providers</description></item>
            /// <item><description><b>regionIds</b>: IDs of supported regions</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;vendor&quot;:0,&quot;regionIds&quot;:{&quot;default&quot;:[&quot;ap-southeast-1&quot;,&quot;ap-northeast-2&quot;,&quot;ap-southeast-3&quot;,&quot;ap-southeast-5&quot;,&quot;ap-southeast-7&quot;,&quot;me-central-1&quot;]}},{&quot;vendor&quot;:1,&quot;regionIds&quot;:{&quot;default&quot;:[&quot;outside-of-aliyun&quot;]}}]</para>
            /// </summary>
            [NameInMap("MultiValues")]
            [Validation(Required=false)]
            public string MultiValues { get; set; }

            /// <summary>
            /// <para>The name of the filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>instanceId</b>: the ID of the instance</description></item>
            /// <item><description><b>instanceName</b>: the name of an instance</description></item>
            /// <item><description><b>internetIp</b>: the public IP address</description></item>
            /// <item><description><b>riskStatus</b>: the risk status</description></item>
            /// <item><description><b>vendorRegionId</b>: the region ID by service provider</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: The filter condition needs to be specified.</description></item>
            /// <item><description><b>select</b>: The filter condition is an option that can be selected from the drop-down list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The values of the search condition. This parameter is returned only if the value of <b>Type</b> is <b>select</b>.</para>
            /// <remarks>
            /// <para> If the value of <b>Type</b> is <b>input</b>, the value of this parameter is an empty string.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fvt*</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
