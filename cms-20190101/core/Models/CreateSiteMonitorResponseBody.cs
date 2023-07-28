// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateSiteMonitorResponseBody : TeaModel {
        /// <summary>
        /// The extended options of the protocol that is used by the site monitoring task. The options vary based on the protocol.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CreateResultList")]
        [Validation(Required=false)]
        public CreateSiteMonitorResponseBodyCreateResultList CreateResultList { get; set; }
        public class CreateSiteMonitorResponseBodyCreateResultList : TeaModel {
            [NameInMap("CreateResultList")]
            [Validation(Required=false)]
            public List<CreateSiteMonitorResponseBodyCreateResultListCreateResultList> CreateResultList { get; set; }
            public class CreateSiteMonitorResponseBodyCreateResultListCreateResultList : TeaModel {
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

        }

        /// <summary>
        /// The result of the site monitoring task.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSiteMonitorResponseBodyData Data { get; set; }
        public class CreateSiteMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("AttachAlertResult")]
            [Validation(Required=false)]
            public CreateSiteMonitorResponseBodyDataAttachAlertResult AttachAlertResult { get; set; }
            public class CreateSiteMonitorResponseBodyDataAttachAlertResult : TeaModel {
                [NameInMap("Contact")]
                [Validation(Required=false)]
                public List<CreateSiteMonitorResponseBodyDataAttachAlertResultContact> Contact { get; set; }
                public class CreateSiteMonitorResponseBodyDataAttachAlertResultContact : TeaModel {
                    /// <summary>
                    /// The status code that is returned after you associate the existing alert rule with the site monitoring task.
                    /// 
                    /// >  The status code 200 indicates that the call was successful.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// The following tables describe the extended options of the HTTP, HTTPS, PING, TCP, UDP, DNS, SMTP. POP3, and FTP protocols specified by the TaskType parameter.  
                    /// 
                    /// - HTTP or HTTPS
                    /// 
                    /// | Parameter | Type | Description |
                    /// | --------- | ---- | ----------- |
                    /// | http_method | String | The HTTP or HTTPS request method. Valid values: GET, POST, and HEAD. Default value: GET. |
                    /// | header | String | The custom HTTP headers that are separated by line feeds (\n). 
                    /// 
                    /// Each header must comply with the HTTP protocol. Each header must be a key-value pair in which the key and value are separated by a colon (:). |
                    /// | cookie | String | The HTTP cookie that is specified in compliance with the HTTP request standard. |
                    /// | request_content | String | The content of the request. The content can be in the JSON or form format. If this parameter is not specified, the request body is empty. |
                    /// | response_content | String | The expected content of the response. The first 64 bytes of the content returned by the HTTP server are checked during site monitoring. |
                    /// | match_rule | String | 0: If the response does not contain the content specified by the response_content parameter, the detection is successful.  
                    /// 
                    /// 1: If the response contains the content specified by the response_content parameter, the detection is successful. |
                    /// | username | String | If the username parameter is specified, the HTTP request contains the basic authentication header. |
                    /// | password | String | The password that is used to authenticate the HTTP or HTTPS request. |
                    /// | time_out | int | The timeout period. Unit: milliseconds. Default value: 5. |
                    /// | max_redirect | int | The maximum number of redirections. The default value is 5 for a detection point that is running on an Elastic Compute Service (ECS) instance and 2 for a detection point that is provided by a carrier.  
                    /// 
                    /// To disable redirections, set the value to 0. 
                    /// 
                    /// Valid values: 0 to 50. |
                    /// - PING
                    /// 
                    /// | Parameter | Type | Description |
                    /// | --------- | ---- | ----------- |
                    /// | failure_rate | Text | If the rate of the failed pings exceeds the value of this parameter, the detection fails and the status code 610 or 615 is returned. The error message of the status code 610 is PingAllFail and the error message of the status code 615 is PingPartialFail. 
                    /// 
                    /// Default value: 0.1. |
                    /// | ping_num | int | The number of times that the monitored address is pinged. Default value: 10. 
                    /// 
                    /// Valid values: 1 to 100. |
                    /// - DNS
                    /// 
                    /// | Parameter | Type | Description |
                    /// | --------- | ---- | ----------- |
                    /// | dns_server | string | The domain name or IP address of the Domain Name System (DNS) server. |
                    /// | dns_type | string | The type of the DNS records to query. Valid values: A, NS, CNAME, MX, TXT, ANY, and AAAA. |
                    /// | expect_value | string | The list of expected values. Separate the expected values with space characters. |
                    /// | match_rule | string | The relationship between the list of expected values and the list of DNS results. If the two lists do not meet the specified relationship, the detection fails. Valid values:    
                    /// 
                    /// Empty string or IN_DNS: The list of expected values is a subset of the list of DNS results.   
                    /// 
                    /// DNS_IN: The list of DNS results is a subset of the list of expected values.    
                    /// 
                    /// EQUAL: The list of DNS results is the same as the list of expected values.   
                    /// 
                    /// ANY: The list of DNS results intersects with the list of expected values. |
                    /// - FTP
                    /// 
                    /// | Parameter | Type | Description |
                    /// | --------- | ---- | ----------- |
                    /// | port | int | The port number of the FTP server. If this parameter is not specified, the default value is used. The default port number is 21 for FTP and 990 for FTPS. |
                    /// | username | string | The username that is used to log on to the FTP server.  If this parameter is not specified, anonymous logon is used. |
                    /// | password | string | The password that is used to log on to the FTP server. |
                    /// - POP3 or SMTP
                    /// 
                    /// | Parameter | Type | Description |
                    /// | --------- | ---- | ----------- |
                    /// | port | int | The port number of the POP3 or SMTP server. The default port number is 110 for POP3, 995 for POPS3, and 25 for SMTP. |
                    /// | username | string | The username that is used to log on to the POP3 or SMTP server. The username and password that are used to log on to the POP3 or SMTP server are required. |
                    /// | password | string | The password that is used to log on to the POP3 or SMTP server. The username and password that are used to log on to the POP3 or SMTP server are required. |
                    /// - TCP or UDP
                    /// 
                    /// | Parameter | Type | Description |
                    /// | --------- | ---- | ----------- |
                    /// | port | int | The port number of the TCP or UDP server. |
                    /// | request_content | string | The content of the request. If the request_format parameter is set to hex, the value of the request_content parameter is parsed in the hexadecimal format. |
                    /// | request_format | string | If the request_format parameter is set to another value, the value of the request_content parameter is sent to the TCP or UDP server as a regular string. |
                    /// | response_content | string | The content of the response. If the response from the TCP or UDP server does not contain the content specified by the response_content parameter, the detection fails.  
                    /// 
                    /// If the response_format parameter is set to hex, the value of the response_content parameter is parsed in the hexadecimal format.  
                    /// 
                    /// If the response_format parameter is set to another value, the value of the response_content parameter is parsed as a regular string. |
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// Creates a site monitoring task.
                    /// </summary>
                    [NameInMap("RequestId")]
                    [Validation(Required=false)]
                    public string RequestId { get; set; }

                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public string RuleId { get; set; }

                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public string Success { get; set; }

                }

            }

        }

        /// <summary>
        /// The URL or IP address that is monitored by the task.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The interval at which detection requests are sent.
        /// 
        /// Valid values: 1, 5, 15, 30, and 60. Unit: minutes.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
