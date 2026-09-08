// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ImportCustomCallTaggingRequest : TeaModel {
        /// <summary>
        /// <para>The ObjectKey of the OSS object that contains the inbound number mark file. OSS is configured with the public customer storage bucket for Cloud Call Center. You can upload the inbound number mark file to this public customer storage bucket through the inbound management page of Cloud Call Center. After the upload succeeds, invoking this API reads the file content from OSS and imports it in batch. We do not recommend directly invoking this API. Instead, you can perform this operation through the default public cloud CRM System provided by Cloud Call Center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temp/ImportCustomCallTagging.xlsx</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
