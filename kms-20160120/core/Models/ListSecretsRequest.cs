// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return the resource tags of the secret. Valid values:
        /// 
        /// *   true: returns the resource tags.
        /// *   false: does not return the resource tags. This is the default value.
        /// </summary>
        [NameInMap("FetchTags")]
        [Validation(Required=false)]
        public string FetchTags { get; set; }

        /// <summary>
        /// The secret filter. The filter consists of one or more key-value pairs. You can specify one key-value pair or leave this parameter empty. If you use one tag key or tag value to filter resources, up to 4,000 resources can be queried. If you want to query more than 4,000 resources, call the [ListResourceTags](~~120090~~) operation.
        /// 
        /// *   Key
        /// 
        ///     *   Description: the property that you want to filter.
        /// 
        ///     *   Type: string.
        /// 
        ///     *   Valid values:
        /// 
        ///         *   SecretName: the secret name.
        ///         *   Description: the description of the secret.
        ///         *   TagKey: the tag key.
        ///         *   TagValue: the tag value.
        /// 
        /// *   Values
        /// 
        ///     *   Description: the value to be included after filtering.
        /// 
        ///     *   Type: string.
        /// 
        ///     *   Length: 0 to 10.
        /// 
        ///     *   Valid values:
        /// 
        ///         *   If the Key field is set to SecretName, the value must be 1 to 192 characters in length and can contain letters, digits, and special characters `_ / + = . @ -`.
        ///         *   If the Key field is set to Description, the value must be 1 to 256 characters in length.
        ///         *   If the Key field is set to TagKey, the value must be 1 to 256 characters in length and can contain letters, digits, and special characters `/ _ - . + = @ :`.
        ///         *   If the Key field is set to TagValue, the value must be 1 to 256 characters in length and can contain letters, numbers, and special characters `/ _ - . + = @ :`.
        /// 
        /// The logical relationship between values of the Values field in a key-value pair is OR. Example: `[ {"Key":"SecretName", "Values":["sec1","sec2"]}]`. In this example, the semantics are `SecretName=sec 1 OR SecretName=sec 2`.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
