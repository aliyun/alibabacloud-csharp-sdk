// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PushingTarget : TeaModel {
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("HttpRequestTarget")]
        [Validation(Required=false)]
        public PushingTargetHttpRequestTarget HttpRequestTarget { get; set; }
        public class PushingTargetHttpRequestTarget : TeaModel {
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("EncryptSignatureKey")]
            [Validation(Required=false)]
            public string EncryptSignatureKey { get; set; }

            [NameInMap("EncryptString")]
            [Validation(Required=false)]
            public string EncryptString { get; set; }

            [NameInMap("EncryptTimestampKey")]
            [Validation(Required=false)]
            public string EncryptTimestampKey { get; set; }

            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<PushingTargetHttpRequestTargetHeaders> Headers { get; set; }
            public class PushingTargetHttpRequestTargetHeaders : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        [NameInMap("TemplateUuid")]
        [Validation(Required=false)]
        public string TemplateUuid { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
