// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAIAgentPhoneNumberRequest : TeaModel {
        /// <summary>
        /// <para>Phone number. Specify Number to directly query the corresponding phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139xxxxxxxxx</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>Page number. Default Value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, indicating the number of records displayed per page. Default Value is 50, with a maximum value of 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Status of the target phone number to query.</para>
        /// <list type="bullet">
        /// <item><description><para>1: &quot;Activation in progress&quot;.</para>
        /// </description></item>
        /// <item><description><para>2: &quot;Normal&quot;.</para>
        /// </description></item>
        /// <item><description><para>3: &quot;Deactivation in progress&quot;.</para>
        /// </description></item>
        /// <item><description><para>4: &quot;Deactivated&quot;.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
