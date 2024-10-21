// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckDomainRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test**.xin</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>create</para>
        /// </summary>
        [NameInMap("FeeCommand")]
        [Validation(Required=false)]
        public string FeeCommand { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USD</para>
        /// </summary>
        [NameInMap("FeeCurrency")]
        [Validation(Required=false)]
        public string FeeCurrency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FeePeriod")]
        [Validation(Required=false)]
        public int? FeePeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
