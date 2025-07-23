// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCloudAccessRequest : TeaModel {
        /// <summary>
        /// <para>The cloud service provider. Set the value to <b>Tencent</b>, which indicates Tencent Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tencent</para>
        /// </summary>
        [NameInMap("CloudName")]
        [Validation(Required=false)]
        public string CloudName { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The AccessKey ID that is used to access cloud resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>276</para>
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>10</b>, <b>20</b>, and <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

    }

}
