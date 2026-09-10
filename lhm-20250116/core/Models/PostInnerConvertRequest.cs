// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class PostInnerConvertRequest : TeaModel {
        /// <summary>
        /// <para>SQL node type mapping, where the key is the source node type and the value is the target node type. If not empty, it will be assembled into <c>workflow.converter.sqlNodeTypeMapping</c> in <c>innerConvertConfig</c> and written via the task configuration update interface after creating the scheduling transformation task.</para>
        /// </summary>
        [NameInMap("sqlConvertMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> SqlConvertMap { get; set; }

        /// <summary>
        /// <para>Source data source name, i.e., the name of the scheduling data source at the source end of the transformation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SourceDS1</para>
        /// </summary>
        [NameInMap("srcDataSourceName")]
        [Validation(Required=false)]
        public string SrcDataSourceName { get; set; }

        /// <summary>
        /// <para>Target data source name, i.e., the name of the scheduling data source at the target end of the transformation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TargetDS1</para>
        /// </summary>
        [NameInMap("tgtDataSourceName")]
        [Validation(Required=false)]
        public string TgtDataSourceName { get; set; }

    }

}
