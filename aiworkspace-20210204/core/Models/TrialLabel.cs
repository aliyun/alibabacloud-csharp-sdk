// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class TrialLabel : TeaModel {
        /// <summary>
        /// <para>Create time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-27T03:30:04Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>Modified time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-27T03:30:04Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>Key of Trial Label</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>trl-v0fw9a0sd8f9af</para>
        /// </summary>
        [NameInMap("TrialId")]
        [Validation(Required=false)]
        public string TrialId { get; set; }

        /// <summary>
        /// <para>Value of Trial Label</para>
        /// 
        /// <b>Example:</b>
        /// <para>value</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
