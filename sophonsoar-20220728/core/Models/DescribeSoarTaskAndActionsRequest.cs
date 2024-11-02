// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarTaskAndActionsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response.</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The playbook UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1077f2f9-25e8-42d9-bfdf-1528e1313f6d</para>
        /// </summary>
        [NameInMap("RequestUuid")]
        [Validation(Required=false)]
        public string RequestUuid { get; set; }

    }

}
