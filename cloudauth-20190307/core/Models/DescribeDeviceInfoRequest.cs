// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeDeviceInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FACE_TEST</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        [NameInMap("ExpiredEndDay")]
        [Validation(Required=false)]
        public string ExpiredEndDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20190401</para>
        /// </summary>
        [NameInMap("ExpiredStartDay")]
        [Validation(Required=false)]
        public string ExpiredStartDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3iJ1AY$oHcu7mC69</para>
        /// </summary>
        [NameInMap("UserDeviceId")]
        [Validation(Required=false)]
        public string UserDeviceId { get; set; }

    }

}
