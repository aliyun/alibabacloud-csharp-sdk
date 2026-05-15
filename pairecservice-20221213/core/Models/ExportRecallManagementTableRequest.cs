// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ExportRecallManagementTableRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("MaxcomputeProjectName")]
        [Validation(Required=false)]
        public string MaxcomputeProjectName { get; set; }

        /// <summary>
        /// <para>maxcompute schema。</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("MaxcomputeSchema")]
        [Validation(Required=false)]
        public string MaxcomputeSchema { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>table-1</para>
        /// </summary>
        [NameInMap("MaxcomputeTableName")]
        [Validation(Required=false)]
        public string MaxcomputeTableName { get; set; }

        [NameInMap("Partitions")]
        [Validation(Required=false)]
        public Dictionary<string, string> Partitions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20250213000000</para>
        /// </summary>
        [NameInMap("RecallManagementTableVersionId")]
        [Validation(Required=false)]
        public string RecallManagementTableVersionId { get; set; }

    }

}
