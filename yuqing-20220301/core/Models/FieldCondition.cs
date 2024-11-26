// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yuqing20220301.Models
{
    public class FieldCondition : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("fieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        [NameInMap("nestFieldPath")]
        [Validation(Required=false)]
        public string NestFieldPath { get; set; }

        [NameInMap("nestFieldValue")]
        [Validation(Required=false)]
        public List<long?> NestFieldValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>=</para>
        /// </summary>
        [NameInMap("operateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yyy</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
