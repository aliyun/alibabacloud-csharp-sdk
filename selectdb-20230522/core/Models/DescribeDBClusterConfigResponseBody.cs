// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeDBClusterConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This parameter is returned only if Resource Access Management (RAM) authentication failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>failed</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The information returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBClusterConfigResponseBodyData Data { get; set; }
        public class DescribeDBClusterConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-wny3li00g02-be</para>
            /// </summary>
            [NameInMap("DbClusterId")]
            [Validation(Required=false)]
            public string DbClusterId { get; set; }

            /// <summary>
            /// <para>The numeric ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6585</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-wny3li00g02</para>
            /// </summary>
            [NameInMap("DbInstanceName")]
            [Validation(Required=false)]
            public string DbInstanceName { get; set; }

            /// <summary>
            /// <para>The details about each parameter returned.</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public List<DescribeDBClusterConfigResponseBodyDataParams> Params { get; set; }
            public class DescribeDBClusterConfigResponseBodyDataParams : TeaModel {
                /// <summary>
                /// <para>The comments on the parameter.</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The default value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter immediately takes effect without requiring a restart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDynamic")]
                [Validation(Required=false)]
                public int? IsDynamic { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter is modifiable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsUserModifiable")]
                [Validation(Required=false)]
                public int? IsUserModifiable { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doris_scanner_thread_pool_thread_num</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value range of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[0-20000]</para>
                /// </summary>
                [NameInMap("Optional")]
                [Validation(Required=false)]
                public string Optional { get; set; }

                /// <summary>
                /// <para>The category of the parameter.</para>
                /// </summary>
                [NameInMap("ParamCategory")]
                [Validation(Required=false)]
                public string ParamCategory { get; set; }

                /// <summary>
                /// <para>The current value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>107841167</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The dynamic code. This parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic message. This parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An error occurred while processing your request.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADF42B18-43FD-5100-83A9-BE81AB70C863</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
