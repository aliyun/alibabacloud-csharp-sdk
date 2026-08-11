// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class UpdateSqlInstanceParamsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>022F36C7-9FB4-5D67-BEBC-3D14B0984463</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateSqlInstanceParamsResponseBodyResult Result { get; set; }
        public class UpdateSqlInstanceParamsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The combined parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;trace\&quot;:\&quot;INFO\&quot;,\&quot;databaseName\&quot;:\&quot;general\&quot;,\&quot;iquan.plan.cache.enable\&quot;:true,\&quot;iquan.plan.prepare.level\&quot;:\&quot;jni.post.optimize\&quot;,\&quot;urlencode_data\&quot;:false,\&quot;formatType\&quot;:\&quot;string\&quot;,\&quot;timeout\&quot;:1000}</para>
            /// </summary>
            [NameInMap("combineParams")]
            [Validation(Required=false)]
            public string CombineParams { get; set; }

            /// <summary>
            /// <para>The comments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Confirm and Execute</para>
            /// </summary>
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select * from test</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The dynamic parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;trace\&quot;:\&quot;INFO\&quot;,\&quot;databaseName\&quot;:\&quot;general\&quot;,\&quot;iquan.plan.cache.enable\&quot;:true,\&quot;iquan.plan.prepare.level\&quot;:\&quot;jni.post.optimize\&quot;,\&quot;urlencode_data\&quot;:false,\&quot;formatType\&quot;:\&quot;string\&quot;,\&quot;timeout\&quot;:1000}</para>
            /// </summary>
            [NameInMap("dynamicParams")]
            [Validation(Required=false)]
            public string DynamicParams { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719221186114</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the instance was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719220182844</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The KV parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;trace\&quot;:\&quot;INFO\&quot;,\&quot;databaseName\&quot;:\&quot;general\&quot;,\&quot;iquan.plan.cache.enable\&quot;:true,\&quot;iquan.plan.prepare.level\&quot;:\&quot;jni.post.optimize\&quot;,\&quot;urlencode_data\&quot;:false,\&quot;formatType\&quot;:\&quot;string\&quot;,\&quot;timeout\&quot;:1000}</para>
            /// </summary>
            [NameInMap("kvpairs")]
            [Validation(Required=false)]
            public string Kvpairs { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("relatedTemplateId")]
            [Validation(Required=false)]
            public long? RelatedTemplateId { get; set; }

            /// <summary>
            /// <para>The static parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;trace\&quot;:\&quot;INFO\&quot;,\&quot;databaseName\&quot;:\&quot;general\&quot;,\&quot;iquan.plan.cache.enable\&quot;:true,\&quot;iquan.plan.prepare.level\&quot;:\&quot;jni.post.optimize\&quot;,\&quot;urlencode_data\&quot;:false,\&quot;formatType\&quot;:\&quot;string\&quot;,\&quot;timeout\&quot;:1000}</para>
            /// </summary>
            [NameInMap("staticParams")]
            [Validation(Required=false)]
            public string StaticParams { get; set; }

            /// <summary>
            /// <para>The template parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;trace\&quot;:\&quot;INFO\&quot;,\&quot;databaseName\&quot;:\&quot;general\&quot;,\&quot;iquan.plan.cache.enable\&quot;:true,\&quot;iquan.plan.prepare.level\&quot;:\&quot;jni.post.optimize\&quot;,\&quot;urlencode_data\&quot;:false,\&quot;formatType\&quot;:\&quot;string\&quot;,\&quot;timeout\&quot;:1000}</para>
            /// </summary>
            [NameInMap("templateParams")]
            [Validation(Required=false)]
            public string TemplateParams { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
