// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryNacosGrayConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryNacosGrayConfigResponseBodyData Data { get; set; }
        public class QueryNacosGrayConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>spring-cloud-a</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test.yaml</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nacos.config.gray.label=test</para>
            /// </summary>
            [NameInMap("GrayRule")]
            [Validation(Required=false)]
            public string GrayRule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Beta(IP)</para>
            /// </summary>
            [NameInMap("GrayRuleName")]
            [Validation(Required=false)]
            public string GrayRuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("GrayRulePriority")]
            [Validation(Required=false)]
            public string GrayRulePriority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Tags</para>
            /// </summary>
            [NameInMap("GrayType")]
            [Validation(Required=false)]
            public string GrayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dubbo</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1742277568000</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>87d14faf58a103ac8840b9c5f1c2a0fe</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE5C32A1-BC0E-4B79-817C-103E4EDF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
