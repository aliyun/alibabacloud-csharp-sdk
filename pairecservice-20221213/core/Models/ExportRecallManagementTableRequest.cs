// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ExportRecallManagementTableRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The MaxCompute project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("MaxcomputeProjectName")]
        [Validation(Required=false)]
        public string MaxcomputeProjectName { get; set; }

        /// <summary>
        /// <para>The MaxCompute project schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("MaxcomputeSchema")]
        [Validation(Required=false)]
        public string MaxcomputeSchema { get; set; }

        /// <summary>
        /// <para>The name of the destination table in MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table-1</para>
        /// </summary>
        [NameInMap("MaxcomputeTableName")]
        [Validation(Required=false)]
        public string MaxcomputeTableName { get; set; }

        /// <summary>
        /// <para>The table partitions to export. The value must be a JSON object where each key is a partition field and its value is the corresponding partition value.</para>
        /// </summary>
        [NameInMap("Partitions")]
        [Validation(Required=false)]
        public Dictionary<string, string> Partitions { get; set; }

        /// <summary>
        /// <para>The version ID of the recall management table. This parameter defaults to the current published version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250213000000</para>
        /// </summary>
        [NameInMap("RecallManagementTableVersionId")]
        [Validation(Required=false)]
        public string RecallManagementTableVersionId { get; set; }

    }

}
