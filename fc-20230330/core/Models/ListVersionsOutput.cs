// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListVersionsOutput : TeaModel {
        /// <summary>
        /// <para>The sorting method of versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FORWARD</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The ID of the next version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The version IDs.</para>
        /// </summary>
        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<Version> Versions { get; set; }

    }

}
