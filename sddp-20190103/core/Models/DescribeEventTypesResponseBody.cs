// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the types of anomalous events.</para>
        /// <remarks>
        /// <para>If you leave the ParentTypeId parameter empty, anomalous event types are returned. If you set the ParentTypeId parameter, anomalous event subtypes under the specified anomalous event type are returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public List<DescribeEventTypesResponseBodyEventTypeList> EventTypeList { get; set; }
        public class DescribeEventTypesResponseBodyEventTypeList : TeaModel {
            /// <summary>
            /// <para>The code of the anomalous event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The description of the anomalous event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Anomalous permission usage,\<em>\</em>\<em>\</em></para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the anomalous event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the anomalous event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Anomalous permission usage</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>An array that consists of anomalous event subtypes.</para>
            /// </summary>
            [NameInMap("SubTypeList")]
            [Validation(Required=false)]
            public List<DescribeEventTypesResponseBodyEventTypeListSubTypeList> SubTypeList { get; set; }
            public class DescribeEventTypesResponseBodyEventTypeListSubTypeList : TeaModel {
                /// <summary>
                /// <para>The service to which the anomalous event detection rule applies. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RDS</para>
                /// </summary>
                [NameInMap("AdaptedProduct")]
                [Validation(Required=false)]
                public string AdaptedProduct { get; set; }

                /// <summary>
                /// <para>The code of the anomalous event subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>020008</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The code of the configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0100**</para>
                /// </summary>
                [NameInMap("ConfigCode")]
                [Validation(Required=false)]
                public string ConfigCode { get; set; }

                /// <summary>
                /// <para>The content format of anomalous event detection rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: numeric values such as thresholds</description></item>
                /// <item><description><b>1</b>: text such as IP addresses</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConfigContentType")]
                [Validation(Required=false)]
                public int? ConfigContentType { get; set; }

                /// <summary>
                /// <para>The description of the configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The period of time for which the permission is not used exceeds the threshold. The specified threshold is ${value} calendar days.</para>
                /// </summary>
                [NameInMap("ConfigDescription")]
                [Validation(Required=false)]
                public string ConfigDescription { get; set; }

                /// <summary>
                /// <para>The value of the configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("ConfigValue")]
                [Validation(Required=false)]
                public string ConfigValue { get; set; }

                /// <summary>
                /// <para>The description of the anomalous event subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Inappropriate configuration-No protection for the MaxCompute sensitive project, \<em>\</em>\<em>\</em></para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The number of times that the anomalous event hits the anomalous event detection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("EventHitCount")]
                [Validation(Required=false)]
                public int? EventHitCount { get; set; }

                /// <summary>
                /// <para>The ID of the anomalous event subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the anomalous event subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Inappropriate configuration-No protection for the MaxCompute sensitive project</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether detection is enabled for the anomalous event subtype. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
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
