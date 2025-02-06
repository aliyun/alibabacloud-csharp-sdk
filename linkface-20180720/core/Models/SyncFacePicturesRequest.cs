// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkFace20180720.Models
{
    public class SyncFacePicturesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testdevice</para>
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun,alibaba</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ztxEorNjU5I4PYVlW4Jr0010374d003</para>
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testproduct</para>
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
