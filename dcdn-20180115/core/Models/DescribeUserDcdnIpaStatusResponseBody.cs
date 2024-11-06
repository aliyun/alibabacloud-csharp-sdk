// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeUserDcdnIpaStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the IPA service is activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>Indicates whether you have overdue payments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InDebt")]
        [Validation(Required=false)]
        public bool? InDebt { get; set; }

        /// <summary>
        /// <para>Indicates whether the grace period for your overdue payments expired.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InDebtOverdue")]
        [Validation(Required=false)]
        public bool? InDebtOverdue { get; set; }

        /// <summary>
        /// <para>Indicates whether the IPA service is available. The IPA service is available when no payment is overdue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OnService")]
        [Validation(Required=false)]
        public bool? OnService { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F51E9C3-728F-4E35-952D-0ED87A06A8A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
