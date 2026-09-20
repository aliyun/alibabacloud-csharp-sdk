// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaDBInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic metadata information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaDBInfoResponseBodyData Data { get; set; }
        public class GetMetaDBInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The engine ID, in the format of <c>Engine type.Engine name</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps.engine_name</para>
            /// </summary>
            [NameInMap("AppGuid")]
            [Validation(Required=false)]
            public string AppGuid { get; set; }

            /// <summary>
            /// <para>The EMR cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("ClusterBizId")]
            [Validation(Required=false)]
            public string ClusterBizId { get; set; }

            /// <summary>
            /// <para>The comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The time when the engine was created.</para>
            /// <para>The value is a 13-digit number, for example, <c>1541576644000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1541576644000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The service endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://service.odpsstg.aliyun-inc.com/">http://service.odpsstg.aliyun-inc.com/</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The environment type. A value of 0 indicates a non-production table. A value of 1 indicates a production table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public int? EnvType { get; set; }

            /// <summary>
            /// <para>The data storage address of the EMR database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdfs://</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The time when the engine was modified.</para>
            /// <para>The value is a 13-digit number, for example, <c>1541576644000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1541576644000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the workspace owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userId</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The name of the workspace owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_name</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The display name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test project</para>
            /// </summary>
            [NameInMap("ProjectNameCn")]
            [Validation(Required=false)]
            public string ProjectNameCn { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>233</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>The database type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hive</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
