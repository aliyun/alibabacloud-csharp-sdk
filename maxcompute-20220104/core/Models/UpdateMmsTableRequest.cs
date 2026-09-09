// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateMmsTableRequest : TeaModel {
        /// <summary>
        /// <para>The name of the destination MaxCompute table. If you do not specify this parameter, the source table name is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dst_table_name</para>
        /// </summary>
        [NameInMap("dstName")]
        [Validation(Required=false)]
        public string DstName { get; set; }

        /// <summary>
        /// <para>The name of the destination MaxCompute project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dst_project_name</para>
        /// </summary>
        [NameInMap("dstProjectName")]
        [Validation(Required=false)]
        public string DstProjectName { get; set; }

        /// <summary>
        /// <para>The schema of the destination MaxCompute project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("dstSchemaName")]
        [Validation(Required=false)]
        public string DstSchemaName { get; set; }

        /// <summary>
        /// <para>The migration status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INIT</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
