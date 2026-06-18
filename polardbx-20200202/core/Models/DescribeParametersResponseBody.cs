// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameter details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyData Data { get; set; }
        public class DescribeParametersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of original parameters.</para>
            /// </summary>
            [NameInMap("ConfigParameters")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyDataConfigParameters> ConfigParameters { get; set; }
            public class DescribeParametersResponseBodyDataConfigParameters : TeaModel {
                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>存储节点私有协议开关(-1关闭，0开启)</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONN_POOL_XPROTO_STORAGE_DB_PORT</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The engine. Default value: polarx.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The DPI engine version. Default value: 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The list of running parameter details.</para>
            /// </summary>
            [NameInMap("RunningParameters")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyDataRunningParameters> RunningParameters { get; set; }
            public class DescribeParametersResponseBodyDataRunningParameters : TeaModel {
                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>存储节点私有协议开关(-1关闭，0开启)</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONN_POOL_XPROTO_STORAGE_DB_PORT</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
