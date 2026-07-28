// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of results per page. Default value: 20. Minimum value: 1. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the resource source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ExportTaskId: resource export ID</para>
        /// </description></item>
        /// <item><description><para>TaskId: Module execution task ID</para>
        /// </description></item>
        /// <item><description><para>StatePath: the OSS path where the resource state is stored.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TaskId</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The specific value of the resource source.</para>
        /// <list type="bullet">
        /// <item><description><para>If sourceType is set to ExportTaskId, the format is ExportTaskId:Version.</para>
        /// </description></item>
        /// <item><description><para>If sourceType is set to TaskId, the format is TaskId.</para>
        /// </description></item>
        /// <item><description><para>If sourceType is set to StatePath, the format is the download URL of the State file.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-235436dsfdgd</para>
        /// </summary>
        [NameInMap("sourceValue")]
        [Validation(Required=false)]
        public string SourceValue { get; set; }

        /// <summary>
        /// <para>The specification that resource properties follow in the response. Valid values: CloudSpec, Terraform.
        /// Default value: CloudSpec.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudSpec</para>
        /// </summary>
        [NameInMap("specType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

    }

}
