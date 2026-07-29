// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class EventMatchRule : TeaModel {
        /// <summary>
        /// <para>Specifies whether to match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MatchState")]
        [Validation(Required=false)]
        public bool? MatchState { get; set; }

        /// <summary>
        /// <para>The full name to match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testBucket/folder1/file1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The prefix to match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testBucket/prefix1xxx</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The suffix to match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>suffix/xxxx.test</para>
        /// </summary>
        [NameInMap("Suffix")]
        [Validation(Required=false)]
        public string Suffix { get; set; }

    }

}
