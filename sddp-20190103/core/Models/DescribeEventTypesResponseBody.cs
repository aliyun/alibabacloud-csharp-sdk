// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of anomalous activity types.</para>
        /// <remarks>
        /// <para>If ParentTypeId is empty, the parent anomalous activity types are returned. If ParentTypeId is not empty, the child anomalous activity types are returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public List<DescribeEventTypesResponseBodyEventTypeList> EventTypeList { get; set; }
        public class DescribeEventTypesResponseBodyEventTypeList : TeaModel {
            /// <summary>
            /// <para>The code of the parent anomalous activity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The description of the parent anomalous activity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Permission usage anomaly, ****</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The unique ID of the parent anomalous activity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the parent anomalous activity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Permission usage anomaly</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of child anomalous activity types.</para>
            /// </summary>
            [NameInMap("SubTypeList")]
            [Validation(Required=false)]
            public List<DescribeEventTypesResponseBodyEventTypeListSubTypeList> SubTypeList { get; set; }
            public class DescribeEventTypesResponseBodyEventTypeListSubTypeList : TeaModel {
                /// <summary>
                /// <para>The products to which the rule applies, including MaxCompute, OSS, AnalyticDB for MySQL, Tablestore, and ApsaraDB RDS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RDS</para>
                /// </summary>
                [NameInMap("AdaptedProduct")]
                [Validation(Required=false)]
                public string AdaptedProduct { get; set; }

                /// <summary>
                /// <para>The code of the child anomalous activity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>020008</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The configuration code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0100**</para>
                /// </summary>
                [NameInMap("ConfigCode")]
                [Validation(Required=false)]
                public string ConfigCode { get; set; }

                /// <summary>
                /// <para>The format of the rule item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: numeric (such as a threshold).</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: text (such as an IP address).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConfigContentType")]
                [Validation(Required=false)]
                public int? ConfigContentType { get; set; }

                /// <summary>
                /// <para>The configuration description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Permission idle period exceeds threshold: current threshold is defined as 7 natural days</para>
                /// </summary>
                [NameInMap("ConfigDescription")]
                [Validation(Required=false)]
                public string ConfigDescription { get; set; }

                /// <summary>
                /// <para>The configuration value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("ConfigValue")]
                [Validation(Required=false)]
                public string ConfigValue { get; set; }

                /// <summary>
                /// <para>The description of the child anomalous activity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Configuration error - MaxCompute sensitive project not protected，****</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The number of times the rule is hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("EventHitCount")]
                [Validation(Required=false)]
                public int? EventHitCount { get; set; }

                /// <summary>
                /// <para>The unique ID of the child anomalous activity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the child anomalous activity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Configuration error - MaxCompute sensitive project not protected</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The detection feature of Data Security Center (DSC) for the child anomalous activity type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: enabled.</para>
                /// </description></item>
                /// <item><description><para><b>0</b>: disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
