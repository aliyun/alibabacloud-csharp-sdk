// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RollbackApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>474bdef0-d149-4695-abfb-52912d91****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The current version number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2-1</para>
        /// </summary>
        [NameInMap("FromAppVersion")]
        [Validation(Required=false)]
        public string FromAppVersion { get; set; }

        /// <summary>
        /// <para>The timeout period of the asynchronous rollback operation. Unit: seconds. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The target version number. By default, the system automatically rolls back the container version to the previous version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("ToAppVersion")]
        [Validation(Required=false)]
        public string ToAppVersion { get; set; }

    }

}
