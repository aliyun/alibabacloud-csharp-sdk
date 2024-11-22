// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSiteCustomLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the custom log field configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6befa4aa-2a94-4f51-a245-295787192d2c</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Indicates whether the custom configuration exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsExist")]
        [Validation(Required=false)]
        public bool? IsExist { get; set; }

        /// <summary>
        /// <para>The custom fields.</para>
        /// </summary>
        [NameInMap("LogCustomField")]
        [Validation(Required=false)]
        public GetSiteCustomLogResponseBodyLogCustomField LogCustomField { get; set; }
        public class GetSiteCustomLogResponseBodyLogCustomField : TeaModel {
            /// <summary>
            /// <para>The cookie fields.</para>
            /// </summary>
            [NameInMap("Cookies")]
            [Validation(Required=false)]
            public List<string> Cookies { get; set; }

            /// <summary>
            /// <para>The request header fields.</para>
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<string> RequestHeaders { get; set; }

            /// <summary>
            /// <para>The response header fields.</para>
            /// </summary>
            [NameInMap("ResponseHeaders")]
            [Validation(Required=false)]
            public List<string> ResponseHeaders { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6befa4aa-2a94-4f51-a245-295787192d2c</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The website ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>167026711***</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
