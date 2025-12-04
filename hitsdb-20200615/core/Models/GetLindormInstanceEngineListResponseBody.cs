// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormInstanceEngineListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AuthAction&quot;:&quot;xxx&quot;,&quot;AuthPrincipalDisplayName&quot;:&quot;222&quot;,&quot;AuthPrincipalOwnerId&quot;:&quot;111&quot;,&quot;AuthPrincipalType&quot;:&quot;SubUser&quot;,,&quot;NoPermissionType&quot;:&quot;ImplicitDeny&quot;,&quot;PolicyType&quot;:&quot;AccountLevelIdentityBasedPolicy&quot;,&quot;EncodedDiagnosticMessage&quot;:&quot;xxxxxx&quot;}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The list of engines that can run on the specified instance.</para>
        /// </summary>
        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<GetLindormInstanceEngineListResponseBodyEngineList> EngineList { get; set; }
        public class GetLindormInstanceEngineListResponseBodyEngineList : TeaModel {
            /// <summary>
            /// <para>The type of engine that can run on the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>lindorm</b>: LindormTable.</description></item>
            /// <item><description><b>tsdb</b>: LindormTSDB.</description></item>
            /// <item><description><b>solr</b>: LindormSearch.</description></item>
            /// <item><description><b>store</b>: LindormDFS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lindorm</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The list of connection information about the engine.</para>
            /// </summary>
            [NameInMap("NetInfoList")]
            [Validation(Required=false)]
            public List<GetLindormInstanceEngineListResponseBodyEngineListNetInfoList> NetInfoList { get; set; }
            public class GetLindormInstanceEngineListResponseBodyEngineListNetInfoList : TeaModel {
                /// <summary>
                /// <para>The method by which the connection information can be used to access LindormTable. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The default value. This value can be ignored.</description></item>
                /// <item><description><b>1</b>: The connection information can be used to access LindormTable by using ApsaraDB for HBase API for Java.</description></item>
                /// <item><description><b>2</b>: The connection information can be used to access LindormTable by using ApsaraDB for HBase API for a non-Java language.</description></item>
                /// <item><description><b>3</b>: The connection information can be used to access LindormTable by using the LindormTable endpoint for CQL.</description></item>
                /// <item><description><b>4</b>: The connection information can be used to access LindormTable by using the LindormTable endpoint for SQL.</description></item>
                /// <item><description><b>5</b>: The connection information can be used to access Lindorm by using the LindormTable endpoint for Amazon S3.</description></item>
                /// <item><description><b>6</b>: The connection information can be used to access Lindorm by using the LindormTable endpoint for MySQL.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AccessType")]
                [Validation(Required=false)]
                public int? AccessType { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to connect to the engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ld-bp1nq34mv3smk****-proxy-lindorm.lindorm.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The network type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Internet</description></item>
                /// <item><description><b>2</b>: virtual private cloud (VPC)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The port number used to connect to the engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30020</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

        }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1nq34mv3smk****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B496BA0E-520C-59FC-BA04-196D8F3B07EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
