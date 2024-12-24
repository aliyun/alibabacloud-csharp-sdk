// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823.Models
{
    public class UpdateColumnRequest : TeaModel {
        [NameInMap("chineseName")]
        [Validation(Required=false)]
        public string ChineseName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>column-AAAAAAAAh6cWOUPagYstkg</para>
        /// </summary>
        [NameInMap("columnIdKey")]
        [Validation(Required=false)]
        public string ColumnIdKey { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("enumType")]
        [Validation(Required=false)]
        public int? EnumType { get; set; }

        [NameInMap("enumValues")]
        [Validation(Required=false)]
        public List<string> EnumValues { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("rangeMax")]
        [Validation(Required=false)]
        public long? RangeMax { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("rangeMin")]
        [Validation(Required=false)]
        public long? RangeMin { get; set; }

        [NameInMap("samples")]
        [Validation(Required=false)]
        public List<string> Samples { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table-AAAAAAAAFQBwSLJkUj4CYg</para>
        /// </summary>
        [NameInMap("tableIdKey")]
        [Validation(Required=false)]
        public string TableIdKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-2v3934xtp49esw64</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
