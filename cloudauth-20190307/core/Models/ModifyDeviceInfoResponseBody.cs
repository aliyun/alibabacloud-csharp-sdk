// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyDeviceInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20190401</para>
        /// </summary>
        [NameInMap("BeginDay")]
        [Validation(Required=false)]
        public string BeginDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FACE_TEST</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wd.6ziUffspAeW5FVYbaqmexR-1qwNjM</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20200330</para>
        /// </summary>
        [NameInMap("ExpiredDay")]
        [Validation(Required=false)]
        public string ExpiredDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3iJ1AY$oHcu7mC69</para>
        /// </summary>
        [NameInMap("UserDeviceId")]
        [Validation(Required=false)]
        public string UserDeviceId { get; set; }

    }

}
