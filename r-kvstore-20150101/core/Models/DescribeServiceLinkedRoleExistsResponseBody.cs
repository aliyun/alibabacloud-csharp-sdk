// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeServiceLinkedRoleExistsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the service-linked role is activated for the current account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The role is activated.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The role is not activated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExistsServiceLinkedRole")]
        [Validation(Required=false)]
        public bool? ExistsServiceLinkedRole { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90B82DB7-FB28-4CC2-ADBF-1F8659F3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
