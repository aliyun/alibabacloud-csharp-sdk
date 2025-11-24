// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class SecretDeleteRecordValue : TeaModel {
        /// <summary>
        /// <para>The result of deleting the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>success</c>: The secret was deleted.</description></item>
        /// <item><description><c>fail</c>: The secret failed to be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD65C0AD-D3C6-48D3-8D93-38D2015C****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The error message returned when exceptions occur. Otherwise, an empty value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>timeout</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
