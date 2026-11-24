// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoBuildRecordRequest : TeaModel {
        /// <summary>
        /// <para>The build record ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a78ec6fb-16ea-4649-93b7-f52afba7d****</para>
        /// </summary>
        [NameInMap("BuildRecordId")]
        [Validation(Required=false)]
        public string BuildRecordId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
