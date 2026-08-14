// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormInstanceEngineListResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why the access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AuthAction&quot;:&quot;xxx&quot;,&quot;AuthPrincipalDisplayName&quot;:&quot;222&quot;,&quot;AuthPrincipalOwnerId&quot;:&quot;111&quot;,&quot;AuthPrincipalType&quot;:&quot;SubUser&quot;,,&quot;NoPermissionType&quot;:&quot;ImplicitDeny&quot;,&quot;PolicyType&quot;:&quot;AccountLevelIdentityBasedPolicy&quot;,&quot;EncodedDiagnosticMessage&quot;:&quot;xxxxxx&quot;}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The list of engine types.</para>
        /// </summary>
        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<GetLindormInstanceEngineListResponseBodyEngineList> EngineList { get; set; }
        public class GetLindormInstanceEngineListResponseBodyEngineList : TeaModel {
            /// <summary>
            /// <para>The engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>lindorm</b>: LindormTable.</para>
            /// </description></item>
            /// <item><description><para><b>tsdb</b>: LindormTSDB.</para>
            /// </description></item>
            /// <item><description><para><b>solr</b>: Search engine.</para>
            /// </description></item>
            /// <item><description><para><b>store</b>: File engine.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lindorm</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The list of database connection information for the engine.</para>
            /// </summary>
            [NameInMap("NetInfoList")]
            [Validation(Required=false)]
            public List<GetLindormInstanceEngineListResponseBodyEngineListNetInfoList> NetInfoList { get; set; }
            public class GetLindormInstanceEngineListResponseBodyEngineListNetInfoList : TeaModel {
                /// <summary>
                /// <para>The connection method for LindormTable. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: This is the default value and can be ignored.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: Use the HBase Java API to access LindormTable.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Use a non-Java HBase API to access LindormTable.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Use CQL to access LindormTable.</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: Use the LindormTable SQL endpoint.</para>
                /// </description></item>
                /// <item><description><para><b>5</b>: Use the S3-compatible endpoint for LindormTable.</para>
                /// </description></item>
                /// <item><description><para><b>6</b>: Use the MySQL-compatible endpoint for LindormTable.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AccessType")]
                [Validation(Required=false)]
                public int? AccessType { get; set; }

                /// <summary>
                /// <para>The database endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ld-bp1nq34mv3smk****-proxy-lindorm.lindorm.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The network type of the database endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Internet.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Virtual private cloud (VPC).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The port number of the database endpoint.</para>
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
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1nq34mv3smk****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B496BA0E-520C-59FC-BA04-196D8F3B07EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
