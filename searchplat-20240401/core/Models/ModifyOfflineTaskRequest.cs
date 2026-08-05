// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class ModifyOfflineTaskRequest : TeaModel {
        /// <summary>
        /// <para>The task metadata.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public ModifyOfflineTaskRequestMeta Meta { get; set; }
        public class ModifyOfflineTaskRequestMeta : TeaModel {
            /// <summary>
            /// <para>The access credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OS-xxx</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The billing specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>small</para>
            /// </summary>
            [NameInMap("computeResource")]
            [Validation(Required=false)]
            public string ComputeResource { get; set; }

            /// <summary>
            /// <para>The list of task labels.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>syh</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <para>The task processing parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;parameter1&quot;: {
        ///        &quot;key&quot;: &quot;value&quot;
        ///     },
        ///     &quot;parameter2&quot;: {
        ///          &quot;key&quot;: &quot;value&quot;
        ///      }
        /// }</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The processing flow operators.</para>
        /// </summary>
        [NameInMap("processors")]
        [Validation(Required=false)]
        public List<ModifyOfflineTaskRequestProcessors> Processors { get; set; }
        public class ModifyOfflineTaskRequestProcessors : TeaModel {
            /// <summary>
            /// <para>The input parameters.</para>
            /// </summary>
            [NameInMap("input")]
            [Validation(Required=false)]
            public Dictionary<string, object> Input { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>processor1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            /// &quot;vector&quot;: &quot;syh_image_uri_multi-modal-embedding&quot;
            /// }</para>
            /// </summary>
            [NameInMap("output")]
            [Validation(Required=false)]
            public Dictionary<string, object> Output { get; set; }

            /// <summary>
            /// <para>The processor parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;service_id&quot;: &quot;xxx&quot;
            /// }</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Parameters { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>document-analyze</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The data sink information.</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public List<ModifyOfflineTaskRequestSink> Sink { get; set; }
        public class ModifyOfflineTaskRequestSink : TeaModel {
            /// <summary>
            /// <para>The data sink name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The data sink configuration parameters, which are determined by the type.</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

            /// <summary>
            /// <para>The primary key field of the data sink.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            /// <summary>
            /// <para>The data sink schema.</para>
            /// </summary>
            [NameInMap("schema")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> Schema { get; set; }

            /// <summary>
            /// <para>The data sink type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swift</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The data source information.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public List<ModifyOfflineTaskRequestSource> Source { get; set; }
        public class ModifyOfflineTaskRequestSource : TeaModel {
            /// <summary>
            /// <para>The data source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tmp-exec-pop-eTcMpC</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The datasource config parameters, which are determined by the type.</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

            /// <summary>
            /// <para>The primary key field of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            /// <summary>
            /// <para>The data source schema.</para>
            /// </summary>
            [NameInMap("schema")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> Schema { get; set; }

            /// <summary>
            /// <para>The data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swift</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The task status.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public ModifyOfflineTaskRequestStatus Status { get; set; }
        public class ModifyOfflineTaskRequestStatus : TeaModel {
            /// <summary>
            /// <para>The task start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1744941600000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The task stop time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1744941600000</para>
            /// </summary>
            [NameInMap("deleteTime")]
            [Validation(Required=false)]
            public long? DeleteTime { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to validate the request parameters without performing the actual operation. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
