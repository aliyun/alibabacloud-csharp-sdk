// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveSnapshotNotifyConfigRequest : TeaModel {
        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ww.yourdomain***.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The callback authentication key. The key must be 16 to 32 characters in length and can contain letters and digits.</para>
        /// <remarks>
        /// <para>This parameter is required when NotifyReqAuth is set to <b>yes</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testkeyyourkey12</para>
        /// </summary>
        [NameInMap("NotifyAuthKey")]
        [Validation(Required=false)]
        public string NotifyAuthKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authentication for callback notifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>yes</b>: Enables</para>
        /// </description></item>
        /// <item><description><para><b>no</b>: Disables</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is <b>no</b>. If you set this parameter to <b>yes</b>, NotifyAuthKey is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("NotifyReqAuth")]
        [Validation(Required=false)]
        public string NotifyReqAuth { get; set; }

        /// <summary>
        /// <para>The callback URL. The URL must be valid and cannot exceed 500 characters.</para>
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

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
