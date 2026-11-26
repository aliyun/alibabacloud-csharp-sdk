// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25C11EE5-B7E8-481A-A07C-BD619971A570</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The recommended upgrade version in the format of &quot;major version,minor version&quot; (separated by a comma). The former is the target major major engine version upgrade, and the latter is the target minor major engine version upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mm.v7.4.2.7-202608031659,mm.v7.3.2.12-202608071438</para>
        /// </summary>
        [NameInMap("VersionSuggestion")]
        [Validation(Required=false)]
        public string VersionSuggestion { get; set; }

    }

}
