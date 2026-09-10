// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class AddDataCheckTaskRequest : TeaModel {
        /// <summary>
        /// <para>The validation template ID. If not specified, the built-in default template is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("checkTemplateId")]
        [Validation(Required=false)]
        public string CheckTemplateId { get; set; }

        /// <summary>
        /// <para>The validation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: data volume comparison.</description></item>
        /// <item><description>1: metric comparison.</description></item>
        /// <item><description>2: weak content comparison.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("checkType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        /// <summary>
        /// <para>The ID of the destination data source.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hive</para>
        /// </summary>
        [NameInMap("dstDsType")]
        [Validation(Required=false)]
        public string DstDsType { get; set; }

        /// <summary>
        /// <para>The ID of the source data source.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hive</para>
        /// </summary>
        [NameInMap("srcDsType")]
        [Validation(Required=false)]
        public string SrcDsType { get; set; }

        /// <summary>
        /// <para>The table detail creation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: table-by-table fine-grained creation.</description></item>
        /// <item><description>1: batch creation with the same schema.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("taskMode")]
        [Validation(Required=false)]
        public int? TaskMode { get; set; }

        /// <summary>
        /// <para>The task name. Only Chinese characters, English characters, and digits are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_check_task_demo</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
