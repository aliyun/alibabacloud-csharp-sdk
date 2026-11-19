// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ImportDriveRequest : TeaModel {
        /// <summary>
        /// <para>The target UPM domain ID. For workspace scenarios, use the UpmDomainId instead of the NAS file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dom-aaaa****</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The target ECD end user ID. The caller account is obtained from the authentication context.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>Specifies whether to force an update. Default value: false. If the file already exists and this parameter is set to false, the request fails. If this parameter is set to true, the original DriveId is reused for the update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceUpdate")]
        [Validation(Required=false)]
        public bool? ForceUpdate { get; set; }

        /// <summary>
        /// <para>The relative path of the cloud application UPM. It must be the same as the path specified during upload authorization. For cloud desktops, do not pass this parameter or pass an empty value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appv1/ab****</para>
        /// </summary>
        [NameInMap("MountUrl")]
        [Validation(Required=false)]
        public string MountUrl { get; set; }

        /// <summary>
        /// <para>The target platform. Valid values: WINDOWS_10, WINDOWS_11, WINDOWS_SERVER_2019, WINDOWS_SERVER_2022, and WINDOWS_SERVER_2025.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WINDOWS_SERVER_2025</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The region of the target UPM.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
