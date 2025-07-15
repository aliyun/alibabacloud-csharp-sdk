// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveSnapshotNotifyConfigRequest : TeaModel {
        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.yourdomain***.com">www.yourdomain***.com</a></para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The callback authentication key. The key must be 16 to 32 characters in length and can contain only letters and digits.</para>
        /// <remarks>
        /// <para>This parameter is required if you set the NotifyReqAuth parameter to <b>yes</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>yourkey</para>
        /// </summary>
        [NameInMap("NotifyAuthKey")]
        [Validation(Required=false)]
        public string NotifyAuthKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable callback authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b></description></item>
        /// <item><description><b>no</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if you set the NotifyAuthKey parameter to yes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("NotifyReqAuth")]
        [Validation(Required=false)]
        public string NotifyReqAuth { get; set; }

        /// <summary>
        /// <para>The callback URL. Specify a valid URL that is up to 500 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://callback.yourdomain***.com">http://callback.yourdomain***.com</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
