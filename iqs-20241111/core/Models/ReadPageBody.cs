// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ReadPageBody : TeaModel {
        [NameInMap("formats")]
        [Validation(Required=false)]
        public List<string> Formats { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1296000</para>
        /// </summary>
        [NameInMap("maxAge")]
        [Validation(Required=false)]
        public int? MaxAge { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("pageTimeout")]
        [Validation(Required=false)]
        public int? PageTimeout { get; set; }

        [NameInMap("readability")]
        [Validation(Required=false)]
        public ReadPageBodyReadability Readability { get; set; }
        public class ReadPageBodyReadability : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("excludeAllImages")]
            [Validation(Required=false)]
            public bool? ExcludeAllImages { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("excludeAllLinks")]
            [Validation(Required=false)]
            public bool? ExcludeAllLinks { get; set; }

            [NameInMap("excludedTags")]
            [Validation(Required=false)]
            public List<string> ExcludedTags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("readabilityMode")]
            [Validation(Required=false)]
            public string ReadabilityMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://help.aliyun.com/document_detail/2837301.html?spm=a2c4g.11186623.help-menu-2837261.d_0_0_0.59ed3e95CppOt2&scm=20140722.H_2837301._.OR_help-T_cn~zh-V_1">https://help.aliyun.com/document_detail/2837301.html?spm=a2c4g.11186623.help-menu-2837261.d_0_0_0.59ed3e95CppOt2&amp;scm=20140722.H_2837301._.OR_help-T_cn~zh-V_1</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
