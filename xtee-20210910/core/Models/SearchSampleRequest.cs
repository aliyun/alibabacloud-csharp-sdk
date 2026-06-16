// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class SearchSampleRequest : TeaModel {
        /// <summary>
        /// <para>The domain name keyword provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of error messages returned by the API. Valid values: zh: Chinese. en: English. Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The area encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("Tab")]
        [Validation(Required=false)]
        public string Tab { get; set; }

        /// <summary>
        /// <para>The access type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAF_CONSOLE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The upload end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-09 14:45:26</para>
        /// </summary>
        [NameInMap("UploadTimeEnd")]
        [Validation(Required=false)]
        public string UploadTimeEnd { get; set; }

        /// <summary>
        /// <para>The upload start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-09 14:12:12</para>
        /// </summary>
        [NameInMap("UploadTimeStart")]
        [Validation(Required=false)]
        public string UploadTimeStart { get; set; }

    }

}
