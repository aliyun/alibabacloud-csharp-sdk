// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class InputOSS : TeaModel {
        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-bucket</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The match expressions.</para>
        /// </summary>
        [NameInMap("MatchExpressions")]
        [Validation(Required=false)]
        public List<string> MatchExpressions { get; set; }

        /// <summary>
        /// <para>The object key prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-object</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

    }

}
