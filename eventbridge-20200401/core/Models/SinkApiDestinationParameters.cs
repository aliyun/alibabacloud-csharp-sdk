// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkApiDestinationParameters : TeaModel {
        /// <summary>
        /// <para>The HTTP body parameters.</para>
        /// </summary>
        [NameInMap("BodyParameters")]
        [Validation(Required=false)]
        public SinkApiDestinationParametersBodyParameters BodyParameters { get; set; }
        public class SinkApiDestinationParametersBodyParameters : TeaModel {
            /// <summary>
            /// <para>Form</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEMPLATE</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>Template</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;message&quot;:&quot;${message}&quot;}</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>Value</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;message&quot;:&quot;$.data.message&quot;}</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The HTTP header parameters.</para>
        /// </summary>
        [NameInMap("HeaderParameters")]
        [Validation(Required=false)]
        public SinkApiDestinationParametersHeaderParameters HeaderParameters { get; set; }
        public class SinkApiDestinationParametersHeaderParameters : TeaModel {
            /// <summary>
            /// <para>Form</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEMPLATE</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>Template</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;${headerName1}&quot;:&quot;${headerValue1}&quot;}</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>Value</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;headerName1&quot;:&quot;X-Example&quot;,&quot;headerValue1&quot;:&quot;example-value&quot;}</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the API destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-api-destination</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The HTTP query parameters.</para>
        /// </summary>
        [NameInMap("QueryStringParameters")]
        [Validation(Required=false)]
        public SinkApiDestinationParametersQueryStringParameters QueryStringParameters { get; set; }
        public class SinkApiDestinationParametersQueryStringParameters : TeaModel {
            /// <summary>
            /// <para>Form</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEMPLATE</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template used to construct the parameter value. This parameter is used only when Form is set to TEMPLATE. You can use variables such as ${event.id} to reference event data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;id&quot;:&quot;${event.id}&quot;}</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>Value</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;id&quot;:&quot;$.data.id&quot;}</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The timeout period for the API call, in seconds. Valid values: 1 to 60. If the destination does not respond within this period, the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
