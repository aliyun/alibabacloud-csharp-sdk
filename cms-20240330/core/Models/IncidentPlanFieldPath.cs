// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentPlanFieldPath : TeaModel {
        /// <summary>
        /// <para>字段别名。</para>
        /// 
        /// <b>Example:</b>
        /// <para>服务名称</para>
        /// </summary>
        [NameInMap("fieldAlias")]
        [Validation(Required=false)]
        public string FieldAlias { get; set; }

        /// <summary>
        /// <para>字段路径的列表。</para>
        /// </summary>
        [NameInMap("fieldPath")]
        [Validation(Required=false)]
        public List<string> FieldPath { get; set; }

    }

}
