// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RollbackApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>The AppId is returned by the CreateApplication operation. FromAppVersion and ToAppVersion must be existing versions created by calling CreateAppVersion. You can call ListAppVersions to query the versions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>474bdef0-d149-4695-abfb-52912d91****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The version number to be rolled back.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2-1</para>
        /// </summary>
        [NameInMap("FromAppVersion")]
        [Validation(Required=false)]
        public string FromAppVersion { get; set; }

        /// <summary>
        /// <para>The timeout period for the asynchronous rollback operation. Unit: seconds. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The target version number. By default, the application is automatically rolled back to the previous version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("ToAppVersion")]
        [Validation(Required=false)]
        public string ToAppVersion { get; set; }

    }

}
