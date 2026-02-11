// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class DescribeCustomerModuleMetaInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A return value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>055f1546-f465-4c92-a2da-bfb86abe6f56</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeCustomerModuleMetaInfoResponseBodyResultObject ResultObject { get; set; }
        public class DescribeCustomerModuleMetaInfoResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Feature list.</para>
            /// </summary>
            [NameInMap("FeatureList")]
            [Validation(Required=false)]
            public List<DescribeCustomerModuleMetaInfoResponseBodyResultObjectFeatureList> FeatureList { get; set; }
            public class DescribeCustomerModuleMetaInfoResponseBodyResultObjectFeatureList : TeaModel {
                /// <summary>
                /// <para>Default value of the feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>Feature mapping name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f1</para>
                /// </summary>
                [NameInMap("FeatureName")]
                [Validation(Required=false)]
                public string FeatureName { get; set; }

                /// <summary>
                /// <para>Feature type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>double</para>
                /// </summary>
                [NameInMap("FeatureType")]
                [Validation(Required=false)]
                public string FeatureType { get; set; }

                /// <summary>
                /// <para>Feature name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Feature template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINANCE_60</para>
            /// </summary>
            [NameInMap("FeatureTemplate")]
            [Validation(Required=false)]
            public string FeatureTemplate { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Call succeeded.</description></item>
        /// <item><description><b>false</b>: Call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
