// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribePcaAndExternalCACertificateListRequest : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>One or more certificate identifiers, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa,bbb</para>
        /// </summary>
        [NameInMap("Identifiers")]
        [Validation(Required=false)]
        public string Identifiers { get; set; }

        /// <summary>
        /// <para>The keyword for a fuzzy search on the name, domain name, and SAN fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. The default value is 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

    }

}
