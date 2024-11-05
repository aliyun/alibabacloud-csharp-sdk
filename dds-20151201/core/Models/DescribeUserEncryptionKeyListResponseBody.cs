// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeUserEncryptionKeyListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of custom keys.</para>
        /// </summary>
        [NameInMap("KeyIds")]
        [Validation(Required=false)]
        public DescribeUserEncryptionKeyListResponseBodyKeyIds KeyIds { get; set; }
        public class DescribeUserEncryptionKeyListResponseBodyKeyIds : TeaModel {
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public List<string> KeyId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7CD51DA4-A499-43CE-B9B5-20CD4FDC648E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
