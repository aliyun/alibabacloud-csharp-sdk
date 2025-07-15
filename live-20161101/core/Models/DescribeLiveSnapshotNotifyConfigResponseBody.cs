// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveSnapshotNotifyConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The main streaming domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.yourdomain***.com">www.yourdomain***.com</a></para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The callback authentication key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourkey</para>
        /// </summary>
        [NameInMap("NotifyAuthKey")]
        [Validation(Required=false)]
        public string NotifyAuthKey { get; set; }

        /// <summary>
        /// <para>Indicates whether callback authentication is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: Callback authentication is enabled.</description></item>
        /// <item><description><b>no</b>: Callback authentication is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("NotifyReqAuth")]
        [Validation(Required=false)]
        public string NotifyReqAuth { get; set; }

        /// <summary>
        /// <para>The callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://callback.yourdomain***.com">http://callback.yourdomain***.com</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5056369B-D337-499E-B8B7-B761BD37B08A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
