// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the app.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110843374</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// <para>The name of the app.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateApptest</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The time when the app was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-29T09:33:01Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The description of the app.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Estimated on October 15, 2021 at 10:20:27</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>扩展信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>110243810311</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The time when the app was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-29T09:33:01Z</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBDB3B0F-EC61-5F33-88AD-EC2446FA1DDB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
