// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class UpdateDataCheckTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the validation template. If this field is not specified, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("checkTemplateId")]
        [Validation(Required=false)]
        public string CheckTemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the destination data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001</para>
        /// </summary>
        [NameInMap("dstDsId")]
        [Validation(Required=false)]
        public string DstDsId { get; set; }

        /// <summary>
        /// <para>The name of the destination data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds_demo</para>
        /// </summary>
        [NameInMap("dstDsName")]
        [Validation(Required=false)]
        public string DstDsName { get; set; }

        /// <summary>
        /// <para>The type of the destination data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hive</para>
        /// </summary>
        [NameInMap("dstDsType")]
        [Validation(Required=false)]
        public string DstDsType { get; set; }

        /// <summary>
        /// <para>The ID of the destination validation engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001</para>
        /// </summary>
        [NameInMap("dstEngineId")]
        [Validation(Required=false)]
        public string DstEngineId { get; set; }

        /// <summary>
        /// <para>The name of the destination validation engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>engine_demo</para>
        /// </summary>
        [NameInMap("dstEngineName")]
        [Validation(Required=false)]
        public string DstEngineName { get; set; }

        /// <summary>
        /// <para>The type of the destination validation engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tez</para>
        /// </summary>
        [NameInMap("dstEngineType")]
        [Validation(Required=false)]
        public string DstEngineType { get; set; }

        /// <summary>
        /// <para>The ID of the task to modify. This field is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The ID of the source data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("srcDsId")]
        [Validation(Required=false)]
        public string SrcDsId { get; set; }

        /// <summary>
        /// <para>The name of the source data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds_demo</para>
        /// </summary>
        [NameInMap("srcDsName")]
        [Validation(Required=false)]
        public string SrcDsName { get; set; }

        /// <summary>
        /// <para>The type of the source data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hive</para>
        /// </summary>
        [NameInMap("srcDsType")]
        [Validation(Required=false)]
        public string SrcDsType { get; set; }

        /// <summary>
        /// <para>The ID of the source validation engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("srcEngineId")]
        [Validation(Required=false)]
        public string SrcEngineId { get; set; }

        /// <summary>
        /// <para>The name of the source validation engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>engine_demo</para>
        /// </summary>
        [NameInMap("srcEngineName")]
        [Validation(Required=false)]
        public string SrcEngineName { get; set; }

        /// <summary>
        /// <para>The type of the source validation engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tez</para>
        /// </summary>
        [NameInMap("srcEngineType")]
        [Validation(Required=false)]
        public string SrcEngineType { get; set; }

        /// <summary>
        /// <para>The description of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data validation task description</para>
        /// </summary>
        [NameInMap("taskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

        /// <summary>
        /// <para>The name of the task. Only Chinese characters, English letters, and digits are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_check_task_demo</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
