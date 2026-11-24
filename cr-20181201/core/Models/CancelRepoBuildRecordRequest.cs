// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CancelRepoBuildRecordRequest : TeaModel {
        /// <summary>
        /// <para>The build record ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74FDBA62-30C0-4F22-BE7B-F1D36FD1****</para>
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

        /// <summary>
        /// <para>The image repository ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-tquyps22md8p****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

    }

}
