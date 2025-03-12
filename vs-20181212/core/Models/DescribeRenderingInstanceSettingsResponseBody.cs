// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingInstanceSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Settings")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceSettingsResponseBodySettings> Settings { get; set; }
        public class DescribeRenderingInstanceSettingsResponseBodySettings : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>navbar.hide</para>
            /// </summary>
            [NameInMap("AttributeName")]
            [Validation(Required=false)]
            public string AttributeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AttributeValue")]
            [Validation(Required=false)]
            public string AttributeValue { get; set; }

        }

    }

}
