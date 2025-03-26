// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListVpdGrantRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListVpdGrantRulesResponseBodyContent Content { get; set; }
        public class ListVpdGrantRulesResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Lingjun CIDR block authorization information list</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListVpdGrantRulesResponseBodyContentData> Data { get; set; }
            public class ListVpdGrantRulesResponseBodyContentData : TeaModel {
                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1643013506000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The current network sample is authorized to the specified Lingjun HUB sample ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-kkopgtne</para>
                /// </summary>
                [NameInMap("ErId")]
                [Validation(Required=false)]
                public string ErId { get; set; }

                /// <summary>
                /// <para>Authorization Entry ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>grant-rule-8rgvqazb</para>
                /// </summary>
                [NameInMap("GrantRuleId")]
                [Validation(Required=false)]
                public string GrantRuleId { get; set; }

                /// <summary>
                /// <para>The ID of the tenant to which the current instance is authorized.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1672372231790</para>
                /// </summary>
                [NameInMap("GrantTenantId")]
                [Validation(Required=false)]
                public string GrantTenantId { get; set; }

                /// <summary>
                /// <para>Lingjun CIDR block instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-8rgvqazb</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-1</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The type of the authorized product. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>VPD</b>: indicates a VPD instance of the Lingjun network segment.</description></item>
                /// <item><description><b>VCC</b>: indicates that Lingjun connects to the VCC instance.</description></item>
                /// </list>
                /// <para>The caller does not need to specify.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPD</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Resource group instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2l4sq6l7unhi</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1655449505171</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>Whether the current authorized instance has been bound</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public bool? Used { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A56F7D3C-8850-5AF4-A342-2D71C9A9D1CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
