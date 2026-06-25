// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class TrialLabel : TeaModel {
        /// <summary>
        /// <para>The time the label was created, in UTC and following the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-27T03:30:04Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time the label was last modified, in UTC and following the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-27T03:30:04Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The key of the label.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The ID of the associated trial.</para>
        /// </summary>
        [NameInMap("TrialId")]
        [Validation(Required=false)]
        public string TrialId { get; set; }

        /// <summary>
        /// <para>The value of the label.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
