// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkApiDestinationParameters : TeaModel {
        /// <summary>
        /// <para>The parameters for the HTTP request body, specified as key-value pairs.</para>
        /// </summary>
        [NameInMap("BodyParameters")]
        [Validation(Required=false)]
        public SinkApiDestinationParametersBodyParameters BodyParameters { get; set; }
        public class SinkApiDestinationParametersBodyParameters : TeaModel {
            /// <summary>
            /// <para>Defines how the parameter\&quot;s value is created. Use <c>CONSTANT</c> to specify a static string in the <c>value</c> field. Use <c>JSONPATH</c> to extract data from the event payload with a JSONPath expression in the <c>value</c> field. Use <c>TEMPLATE</c> to build the value from the <c>template</c> field.</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template to use to build the parameter value. This field is used only when the <c>form</c> is set to <c>TEMPLATE</c>. You can use variables, such as <c>${event.id}</c>, in the template to reference event data.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The static value or JSONPath expression for the parameter. This field applies only when the <c>form</c> is set to <c>CONSTANT</c> or <c>JSONPATH</c>.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The custom HTTP header parameters to add to the request, specified as key-value pairs.</para>
        /// </summary>
        [NameInMap("HeaderParameters")]
        [Validation(Required=false)]
        public SinkApiDestinationParametersHeaderParameters HeaderParameters { get; set; }
        public class SinkApiDestinationParametersHeaderParameters : TeaModel {
            /// <summary>
            /// <para>Defines how the parameter\&quot;s value is created. Use <c>CONSTANT</c> to specify a static string in the <c>value</c> field. Use <c>JSONPATH</c> to extract data from the event payload with a JSONPath expression in the <c>value</c> field. Use <c>TEMPLATE</c> to build the value from the <c>template</c> field.</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template to use to build the parameter value. This field is used only when the <c>form</c> is set to <c>TEMPLATE</c>. You can use variables, such as <c>${event.id}</c>, in the template to reference event data.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The static value or JSONPath expression for the parameter. This field applies only when the <c>form</c> is set to <c>CONSTANT</c> or <c>JSONPATH</c>.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the API destination.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The query string parameters to add to the endpoint URL, specified as key-value pairs.</para>
        /// </summary>
        [NameInMap("QueryStringParameters")]
        [Validation(Required=false)]
        public SinkApiDestinationParametersQueryStringParameters QueryStringParameters { get; set; }
        public class SinkApiDestinationParametersQueryStringParameters : TeaModel {
            /// <summary>
            /// <para>Defines how the parameter\&quot;s value is created. Use <c>CONSTANT</c> to specify a static string in the <c>value</c> field. Use <c>JSONPATH</c> to extract data from the event payload with a JSONPath expression in the <c>value</c> field. Use <c>TEMPLATE</c> to build the value from the <c>template</c> field.</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template to use to build the parameter value. This field is used only when the <c>form</c> is set to <c>TEMPLATE</c>. You can use variables, such as <c>${event.id}</c>, in the template to reference event data.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The static value or JSONPath expression for the parameter. This field applies only when the <c>form</c> is set to <c>CONSTANT</c> or <c>JSONPATH</c>.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The timeout for the API call, in seconds. If the endpoint does not respond within this period, the call fails. The valid range is 1 to 60.</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
