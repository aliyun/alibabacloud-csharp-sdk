// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnDomainStagingConfigResponseBody : TeaModel {
        /// <summary>
        /// You can set multiple records for some features, such as the edge_function feature. To update a record, you can set the ConfigId (Long type) field to specify the configuration items that you want to modify. Syntax: 
        /// 
        /// ```
        /// [{"functionArgs":[{"argName":"enable","argValue":"on"},{"argName":"pri","argValue":"1"},{"argName":"rule","argValue":"yyy"}],"ConfigId":123456,"functionName":"edge_function"}]
        /// ```
        /// **Description**All parameter values are of the string type.
        /// 
        /// | Feature | Parameter |
        /// | ------- | --------- |
        /// | edge_function: EdgeScript functions | Required parameters:
        /// 
        /// rule: the domain-specific language (DSL) script.
        /// 
        /// pri: the priority of the script.
        /// 
        /// enable: specifies whether to enable the script. Valid values: on and off.
        /// 
        ///  Optional parameters:
        /// 
        /// name: the name of the script.
        /// 
        /// pos: specifies whether to execute the script at the start or end of the request processing pipeline. For the accelerated domain names of Dynamic Route for CDN (DCDN), only the value of head is supported. The value of foot is not supported. 
        /// 
        /// brk: After the script is matched, the subsequent scripts at the specified position are skipped. 
        /// 
        /// option: option control.
        /// 
        /// grammar: grammar control. Valid values: null, es2, and js.
        /// 
        /// jsmode: control of the JavaScript domain name whitelist. Valid values: redirect and bypass. |
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
